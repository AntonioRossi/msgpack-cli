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
    public class MsgPack_Serialization_InterfaceMemberRuntimeTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.InterfaceMemberRuntimeType> {
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.IFileSystemEntry> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType> this_PackValueOfValuePackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.InterfaceMemberRuntimeType, MsgPack.Serialization.IFileSystemEntry> this_SetUnpackedValueOfValueSetUnpackedValueOfValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int> this_UnpackValueOfValueUnpackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_InterfaceMemberRuntimeTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry));
            this._serializer0 = context.GetSerializer<MsgPack.Serialization.IFileSystemEntry>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>(this.PackValueOfValue);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
            this.this_PackValueOfValuePackValueOfValueDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceMemberRuntimeType>(this.PackValueOfValue);
            this.this_SetUnpackedValueOfValueSetUnpackedValueOfValueDelegate = new System.Action<MsgPack.Serialization.InterfaceMemberRuntimeType, MsgPack.Serialization.IFileSystemEntry>(this.SetUnpackedValueOfValue);
            this.this_UnpackValueOfValueUnpackValueOfValueDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType, int, int>(this.UnpackValueOfValue);
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.InterfaceMemberRuntimeType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.InterfaceMemberRuntimeType objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfValue(MsgPack.Serialization.InterfaceMemberRuntimeType unpackingContext, MsgPack.Serialization.IFileSystemEntry unpackedValue) {
            unpackingContext.Value = unpackedValue;
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.InterfaceMemberRuntimeType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(MsgPack.Serialization.IFileSystemEntry), "Value", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfValueSetUnpackedValueOfValueDelegate);
        }
        
        protected internal override MsgPack.Serialization.InterfaceMemberRuntimeType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.InterfaceMemberRuntimeType result = default(MsgPack.Serialization.InterfaceMemberRuntimeType);
            result = new MsgPack.Serialization.InterfaceMemberRuntimeType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceMemberRuntimeType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceMemberRuntimeType>(), this._unpackOperationTable);
            }
        }
    }
}
