﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, string>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty> this_PackValueOfDictPolymorphicItselfPackValueOfDictPolymorphicItselfDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>> _packOperationTable;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty_set_DictPolymorphicItself0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, System.Collections.Generic.IDictionary<string, string>> this_SetUnpackedValueOfDictPolymorphicItselfSetUnpackedValueOfDictPolymorphicItselfDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int> this_UnpackValueOfDictPolymorphicItselfUnpackValueOfDictPolymorphicItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> typeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0.Add("0", typeof(System.Collections.Generic.Dictionary<string, string>));
            typeMap0.Add("1", typeof(System.Collections.Generic.SortedDictionary<string, string>));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicDictionary(typeof(System.Collections.Generic.IDictionary<string, string>), typeMap0, null, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, string>>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty_set_DictPolymorphicItself0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty).GetMethod("set_DictPolymorphicItself", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Collections.Generic.IDictionary<string, string>)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(this.PackValueOfDictPolymorphicItself);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>>(1);
            packOperationTable["DictPolymorphicItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(this.PackValueOfDictPolymorphicItself);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>>(1);
            unpackOperationTable["DictPolymorphicItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictPolymorphicItself"};
            this.this_PackValueOfDictPolymorphicItselfPackValueOfDictPolymorphicItselfDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(this.PackValueOfDictPolymorphicItself);
            this.this_SetUnpackedValueOfDictPolymorphicItselfSetUnpackedValueOfDictPolymorphicItselfDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, System.Collections.Generic.IDictionary<string, string>>(this.SetUnpackedValueOfDictPolymorphicItself);
            this.this_UnpackValueOfDictPolymorphicItselfUnpackValueOfDictPolymorphicItselfDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicItself);
        }
        
        private void PackValueOfDictPolymorphicItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicItself);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfDictPolymorphicItself(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty unpackingContext, System.Collections.Generic.IDictionary<string, string> unpackedValue) {
            if ((unpackingContext.DictPolymorphicItself == null)) {
                this._methodBasePolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty_set_DictPolymorphicItself0.Invoke(unpackingContext, new object[] {
                            unpackedValue});
            }
            else {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> enumerator = unpackedValue.GetEnumerator();
                System.Collections.Generic.KeyValuePair<string, string> current;
                try {
                    for (
                    ; enumerator.MoveNext(); 
                    ) {
                        current = enumerator.Current;
                        unpackingContext.DictPolymorphicItself.Add(current.Key, current.Value);
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
        }
        
        private void UnpackValueOfDictPolymorphicItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, string>), "DictPolymorphicItself", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictPolymorphicItselfSetUnpackedValueOfDictPolymorphicItselfDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
