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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<string>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField> this_PackValueOfTuple1StaticPackValueOfTuple1StaticDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, System.Tuple<string>> this_SetUnpackedValueOfTuple1StaticSetUnpackedValueOfTuple1StaticDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int> this_UnpackValueOfTuple1StaticUnpackValueOfTuple1StaticDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[1];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = null;
            tupleItemsSchema0[0] = tupleItemSchema0;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<string>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>(this.PackValueOfTuple1Static);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>>(1);
            packOperationTable["Tuple1Static"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>(this.PackValueOfTuple1Static);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>(this.UnpackValueOfTuple1Static);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>>(1);
            unpackOperationTable["Tuple1Static"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>(this.UnpackValueOfTuple1Static);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple1Static"};
            this.this_PackValueOfTuple1StaticPackValueOfTuple1StaticDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>(this.PackValueOfTuple1Static);
            this.this_SetUnpackedValueOfTuple1StaticSetUnpackedValueOfTuple1StaticDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, System.Tuple<string>>(this.SetUnpackedValueOfTuple1Static);
            this.this_UnpackValueOfTuple1StaticUnpackValueOfTuple1StaticDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField, int, int>(this.UnpackValueOfTuple1Static);
        }
        
        private void PackValueOfTuple1Static(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple1Static);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfTuple1Static(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField unpackingContext, System.Tuple<string> unpackedValue) {
            unpackingContext.Tuple1Static = unpackedValue;
        }
        
        private void UnpackValueOfTuple1Static(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Tuple<string>), "Tuple1Static", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTuple1StaticSetUnpackedValueOfTuple1StaticDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple1StaticReadWriteField>(), this._unpackOperationTable);
            }
        }
    }
}
