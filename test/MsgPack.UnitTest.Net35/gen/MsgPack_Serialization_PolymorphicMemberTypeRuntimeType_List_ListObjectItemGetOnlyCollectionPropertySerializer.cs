﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<object>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty> this_PackValueOfListObjectItemPackValueOfListObjectItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, System.Collections.Generic.IList<object>> this_SetUnpackedValueOfListObjectItemSetUnpackedValueOfListObjectItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int> this_UnpackValueOfListObjectItemUnpackValueOfListObjectItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema itemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            itemsSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedCollection(typeof(System.Collections.Generic.IList<object>), itemsSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<object>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>(this.PackValueOfListObjectItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>>(1);
            packOperationTable["ListObjectItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>(this.PackValueOfListObjectItem);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfListObjectItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>>(1);
            unpackOperationTable["ListObjectItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfListObjectItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "ListObjectItem"};
            this.this_PackValueOfListObjectItemPackValueOfListObjectItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>(this.PackValueOfListObjectItem);
            this.this_SetUnpackedValueOfListObjectItemSetUnpackedValueOfListObjectItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, System.Collections.Generic.IList<object>>(this.SetUnpackedValueOfListObjectItem);
            this.this_UnpackValueOfListObjectItemUnpackValueOfListObjectItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfListObjectItem);
        }
        
        private void PackValueOfListObjectItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListObjectItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfListObjectItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty unpackingContext, System.Collections.Generic.IList<object> unpackedValue) {
            System.Collections.Generic.IEnumerator<object> enumerator = unpackedValue.GetEnumerator();
            object current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    unpackingContext.ListObjectItem.Add(current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfListObjectItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IList<object>), "ListObjectItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfListObjectItemSetUnpackedValueOfListObjectItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemGetOnlyCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
