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
    public class MsgPack_Serialization_ComplexTypeWithNonSerializedSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithNonSerialized> {
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized> this_PackValueOfDataPackValueOfDataDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized> this_PackValueOfHistoryPackValueOfHistoryDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer2;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized> this_PackValueOfSourcePackValueOfSourceDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer3;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized> this_PackValueOfTimeStampPackValueOfTimeStampDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, byte[]> this_SetUnpackedValueOfDataSetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueUnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int> this_UnpackValueOfDataUnpackValueOfDataDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistorySetUnpackedValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int> this_UnpackValueOfHistoryUnpackValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, System.Uri> this_SetUnpackedValueOfSourceSetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int> this_UnpackValueOfSourceUnpackValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, System.DateTime> this_SetUnpackedValueOfTimeStampSetUnpackedValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int> this_UnpackValueOfTimeStampUnpackValueOfTimeStampDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeWithNonSerializedSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<byte[]>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Uri>(schema2);
            this._serializer3 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>[4];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfData);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfHistory);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfSource);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfTimeStamp);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>>(4);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfData);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfHistory);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfSource);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfTimeStamp);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>[4];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfData);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfHistory);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfSource);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>>(4);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfData);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Data",
                    "History",
                    "Source",
                    "TimeStamp"};
            this.this_PackValueOfDataPackValueOfDataDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfData);
            this.this_PackValueOfHistoryPackValueOfHistoryDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfHistory);
            this.this_PackValueOfSourcePackValueOfSourceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfSource);
            this.this_PackValueOfTimeStampPackValueOfTimeStampDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithNonSerialized>(this.PackValueOfTimeStamp);
            this.this_SetUnpackedValueOfDataSetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueUnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_UnpackValueOfDataUnpackValueOfDataDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfData);
            this.this_SetUnpackedValueOfHistorySetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_UnpackValueOfHistoryUnpackValueOfHistoryDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfHistory);
            this.this_SetUnpackedValueOfSourceSetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_UnpackValueOfSourceUnpackValueOfSourceDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfSource);
            this.this_SetUnpackedValueOfTimeStampSetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithNonSerialized, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
            this.this_UnpackValueOfTimeStampUnpackValueOfTimeStampDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized, int, int>(this.UnpackValueOfTimeStamp);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithNonSerialized objectTree) {
            this._serializer0.PackTo(packer, objectTree.Data);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithNonSerialized objectTree) {
            this._serializer1.PackTo(packer, objectTree.History);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithNonSerialized objectTree) {
            this._serializer2.PackTo(packer, objectTree.Source);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithNonSerialized objectTree) {
            this._serializer3.PackTo(packer, objectTree.TimeStamp);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithNonSerialized objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(byte[]), "Data", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueUnpackBinaryValueDelegate, this.this_SetUnpackedValueOfDataSetUnpackedValueOfDataDelegate);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    unpackingContext.History.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<System.DateTime, string>), "History", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfHistorySetUnpackedValueOfHistoryDelegate);
        }
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(System.Uri), "Source", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfSourceSetUnpackedValueOfSourceDelegate);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithNonSerialized unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer3, itemsCount, indexOfItem, typeof(System.DateTime), "TimeStamp", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTimeStampSetUnpackedValueOfTimeStampDelegate);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithNonSerialized UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithNonSerialized result = default(MsgPack.Serialization.ComplexTypeWithNonSerialized);
            result = new MsgPack.Serialization.ComplexTypeWithNonSerialized();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithNonSerialized>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithNonSerialized>(), this._unpackOperationTable);
            }
        }
    }
}
