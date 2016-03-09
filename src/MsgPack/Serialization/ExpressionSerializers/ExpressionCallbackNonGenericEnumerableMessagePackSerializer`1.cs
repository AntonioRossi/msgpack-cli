#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2015 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
#if CORE_CLR
using Contract = MsgPack.MPContract;
#else
using System.Diagnostics.Contracts;
#endif // CORE_CLR
using MsgPack.Serialization.CollectionSerializers;

namespace MsgPack.Serialization.ExpressionSerializers
{
	/// <summary>
	///		A helper <see cref="NonGenericEnumerableMessagePackSerializer{TCollection}"/> for <see cref="ExpressionTreeSerializerBuilder"/>.
	/// </summary>
	/// <typeparam name="TCollection">The type of the collection.</typeparam>
	internal class ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection> :
		NonGenericEnumerableMessagePackSerializer<TCollection>
		where TCollection : IEnumerable
	{
		private readonly Func<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, SerializationContext, int, TCollection> _createInstance;

		private readonly Func<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, SerializationContext, Unpacker, TCollection> _unpackFromCore;

		private readonly Action<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, SerializationContext, TCollection, object> _addItem;
		
		public Action<Unpacker, TCollection, int> UnpackToAction { get; private set; }

		public IDictionary<string, Delegate> PrivateMethods { get; private set; }

		/// <summary>
		///		Initializes a new instance of the <see cref="ExpressionCallbackNonGenericEnumerableMessagePackSerializer{TCollection}"/> class.
		/// </summary>
		/// <param name="ownerContext">A <see cref="SerializationContext"/> which owns this serializer.</param>
		/// <param name="schema">
		///		The schema for collection itself or its items for the member this instance will be used to. 
		///		<c>null</c> will be considered as <see cref="PolymorphismSchema.Default"/>.
		/// </param>
		/// <param name="createInstance">The delegate to <c>CreateInstance</c> method body. This value must not be <c>null</c>.</param>
		/// <param name="unpackFromCore">The delegate to <c>UnpackFromCore</c> method body. This value must not be <c>null</c>.</param>
		/// <param name="addItem">The delegate to <c>AddItem</c> method body. This value can be <c>null</c>.</param>
		/// <param name="unpackTo">The delegate to <c>UnpackToCore</c> method body.</param>
		/// <param name="privateMethods">The lamda expression to &quot;private methods&quot; with their names.</param>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="ownerContext"/> is <c>null</c>.
		/// </exception>
		public ExpressionCallbackNonGenericEnumerableMessagePackSerializer(
			SerializationContext ownerContext,
			PolymorphismSchema schema,
			Func<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, SerializationContext, int, TCollection> createInstance,
			Func<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, SerializationContext, Unpacker, TCollection> unpackFromCore,
			Action<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, SerializationContext, TCollection, object> addItem,
			Delegate unpackTo,
			IDictionary<string, LambdaExpression> privateMethods
		)
			: base( ownerContext, schema )
		{
#if DEBUG
			Contract.Assert( createInstance != null );
			Contract.Assert( unpackFromCore != null );
			Contract.Assert( privateMethods != null );
#endif // DEBUG
			this._createInstance = createInstance;
			this._unpackFromCore = unpackFromCore;
			this._addItem = addItem;
			if ( unpackTo != null )
			{
#if DEBUG
				Contract.Assert( unpackTo is Action<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, Unpacker, TCollection, int> );
#endif // DEBUG
				var noContextUnpackTo =
					unpackTo as Action<ExpressionCallbackNonGenericEnumerableMessagePackSerializer<TCollection>, Unpacker, TCollection, int>;
				this.UnpackToAction = ( unpacker, collection, itemsCount ) => noContextUnpackTo( this, unpacker, collection, itemsCount );
			}

			this.PrivateMethods = ExpressionTreeSerializerBuilderHelpers.SupplyPrivateMethodCommonArguments( this, privateMethods );
		}

		protected override TCollection CreateInstance( int initialCapacity )
		{
			return this._createInstance( this, this.OwnerContext, initialCapacity );
		}

		protected internal override TCollection UnpackFromCore( Unpacker unpacker )
		{
			return this._unpackFromCore( this, this.OwnerContext, unpacker );
		}

		protected override void AddItem( TCollection collection, object item )
		{
			if ( this._addItem != null )
			{
				this._addItem( this, this.OwnerContext, collection, item );
			}
			else
			{
				base.AddItem( collection, item );
			}
		}
	}
}