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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<string, string, string, string, string, string, string, System.Tuple<MsgPack.Serialization.FileSystemEntry>>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty> this_PackValueOfTuple8LastPolymorphicPackValueOfTuple8LastPolymorphicDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, System.Tuple<string, string, string, string, string, string, string, System.Tuple<MsgPack.Serialization.FileSystemEntry>>> this_SetUnpackedValueOfTuple8LastPolymorphicSetUnpackedValueOfTuple8LastPolymorphicDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int> this_UnpackValueOfTuple8LastPolymorphicUnpackValueOfTuple8LastPolymorphicDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[8];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = null;
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema1 = null;
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = null;
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema3 = null;
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema4 = null;
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema5 = null;
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema6 = null;
            tupleItemsSchema0[6] = tupleItemSchema6;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema7 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> tupleItemSchema7TypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            tupleItemSchema7TypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            tupleItemSchema7TypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema7TypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema7 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema7TypeMap0);
            tupleItemsSchema0[7] = tupleItemSchema7;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<string, string, string, string, string, string, string, System.Tuple<MsgPack.Serialization.FileSystemEntry>>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<string, string, string, string, string, string, string, System.Tuple<MsgPack.Serialization.FileSystemEntry>>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>(this.PackValueOfTuple8LastPolymorphic);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>>(1);
            packOperationTable["Tuple8LastPolymorphic"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>(this.PackValueOfTuple8LastPolymorphic);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>(this.UnpackValueOfTuple8LastPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>>(1);
            unpackOperationTable["Tuple8LastPolymorphic"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>(this.UnpackValueOfTuple8LastPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple8LastPolymorphic"};
            this.this_PackValueOfTuple8LastPolymorphicPackValueOfTuple8LastPolymorphicDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>(this.PackValueOfTuple8LastPolymorphic);
            this.this_SetUnpackedValueOfTuple8LastPolymorphicSetUnpackedValueOfTuple8LastPolymorphicDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, System.Tuple<string, string, string, string, string, string, string, System.Tuple<MsgPack.Serialization.FileSystemEntry>>>(this.SetUnpackedValueOfTuple8LastPolymorphic);
            this.this_UnpackValueOfTuple8LastPolymorphicUnpackValueOfTuple8LastPolymorphicDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty, int, int>(this.UnpackValueOfTuple8LastPolymorphic);
        }
        
        private void PackValueOfTuple8LastPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple8LastPolymorphic);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfTuple8LastPolymorphic(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty unpackingContext, System.Tuple<string, string, string, string, string, string, string, System.Tuple<MsgPack.Serialization.FileSystemEntry>> unpackedValue) {
            unpackingContext.Tuple8LastPolymorphic = unpackedValue;
        }
        
        private void UnpackValueOfTuple8LastPolymorphic(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Tuple<string, string, string, string, string, string, string, System.Tuple<MsgPack.Serialization.FileSystemEntry>>), "Tuple8LastPolymorphic", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTuple8LastPolymorphicSetUnpackedValueOfTuple8LastPolymorphicDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple8LastPolymorphicReadWriteProperty>(), this._unpackOperationTable);
            }
        }
    }
}
