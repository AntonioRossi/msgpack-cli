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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty> this_PackValueOfTuple1ObjectItselfPackValueOfTuple1ObjectItselfDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, object> this_SetUnpackedValueOfTuple1ObjectItselfSetUnpackedValueOfTuple1ObjectItselfDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int> this_UnpackValueOfTuple1ObjectItselfUnpackValueOfTuple1ObjectItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            this._serializer0 = context.GetSerializer<object>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>(this.PackValueOfTuple1ObjectItself);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>>(1);
            packOperationTable["Tuple1ObjectItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>(this.PackValueOfTuple1ObjectItself);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>>(1);
            unpackOperationTable["Tuple1ObjectItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple1ObjectItself"};
            this.this_PackValueOfTuple1ObjectItselfPackValueOfTuple1ObjectItselfDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>(this.PackValueOfTuple1ObjectItself);
            this.this_SetUnpackedValueOfTuple1ObjectItselfSetUnpackedValueOfTuple1ObjectItselfDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, object>(this.SetUnpackedValueOfTuple1ObjectItself);
            this.this_UnpackValueOfTuple1ObjectItselfUnpackValueOfTuple1ObjectItselfDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty, int, int>(this.UnpackValueOfTuple1ObjectItself);
        }
        
        private void PackValueOfTuple1ObjectItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple1ObjectItself);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfTuple1ObjectItself(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty unpackingContext, object unpackedValue) {
            unpackingContext.Tuple1ObjectItself = unpackedValue;
        }
        
        private void UnpackValueOfTuple1ObjectItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(object), "Tuple1ObjectItself", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTuple1ObjectItselfSetUnpackedValueOfTuple1ObjectItselfDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfReadWriteProperty>(), this._unpackOperationTable);
            }
        }
    }
}
