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
    public class MsgPack_Serialization_TestValueTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.TestValueType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<int, int>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType> this_PackValueOfDictionaryFieldPackValueOfDictionaryFieldDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<int[]> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType> this_PackValueOfInt32ArrayFieldPackValueOfInt32ArrayFieldDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer2;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType> this_PackValueOfStringFieldPackValueOfStringFieldDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>> _packOperationTable;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.TestValueType> this_CreateInstanceFromContextCreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, System.Collections.Generic.Dictionary<int, int>> this_SetUnpackedValueOfDictionaryFieldSetUnpackedValueOfDictionaryFieldDelegate;
        
        private System.Action<MsgPack.Unpacker, UnpackingContext, int, int> this_UnpackValueOfDictionaryFieldUnpackValueOfDictionaryFieldDelegate;
        
        private System.Action<UnpackingContext, int[]> this_SetUnpackedValueOfInt32ArrayFieldSetUnpackedValueOfInt32ArrayFieldDelegate;
        
        private System.Action<MsgPack.Unpacker, UnpackingContext, int, int> this_UnpackValueOfInt32ArrayFieldUnpackValueOfInt32ArrayFieldDelegate;
        
        private System.Action<UnpackingContext, string> this_SetUnpackedValueOfStringFieldSetUnpackedValueOfStringFieldDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueUnpackStringValueDelegate;
        
        private System.Action<MsgPack.Unpacker, UnpackingContext, int, int> this_UnpackValueOfStringFieldUnpackValueOfStringFieldDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_TestValueTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.Dictionary<int, int>>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<int[]>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<string>(schema2);
            System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfDictionaryField);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfInt32ArrayField);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfStringField);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>>(3);
            packOperationTable["DictionaryField"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfDictionaryField);
            packOperationTable["Int32ArrayField"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfInt32ArrayField);
            packOperationTable["StringField"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfStringField);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfDictionaryField);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfInt32ArrayField);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfStringField);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(3);
            unpackOperationTable["DictionaryField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfDictionaryField);
            unpackOperationTable["Int32ArrayField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfInt32ArrayField);
            unpackOperationTable["StringField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfStringField);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictionaryField",
                    "Int32ArrayField",
                    "StringField"};
            this.this_PackValueOfDictionaryFieldPackValueOfDictionaryFieldDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfDictionaryField);
            this.this_PackValueOfInt32ArrayFieldPackValueOfInt32ArrayFieldDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfInt32ArrayField);
            this.this_PackValueOfStringFieldPackValueOfStringFieldDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfStringField);
            this.this_CreateInstanceFromContextCreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.TestValueType>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfDictionaryFieldSetUnpackedValueOfDictionaryFieldDelegate = new System.Action<UnpackingContext, System.Collections.Generic.Dictionary<int, int>>(this.SetUnpackedValueOfDictionaryField);
            this.this_UnpackValueOfDictionaryFieldUnpackValueOfDictionaryFieldDelegate = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfDictionaryField);
            this.this_SetUnpackedValueOfInt32ArrayFieldSetUnpackedValueOfInt32ArrayFieldDelegate = new System.Action<UnpackingContext, int[]>(this.SetUnpackedValueOfInt32ArrayField);
            this.this_UnpackValueOfInt32ArrayFieldUnpackValueOfInt32ArrayFieldDelegate = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfInt32ArrayField);
            this.this_SetUnpackedValueOfStringFieldSetUnpackedValueOfStringFieldDelegate = new System.Action<UnpackingContext, string>(this.SetUnpackedValueOfStringField);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueUnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
            this.this_UnpackValueOfStringFieldUnpackValueOfStringFieldDelegate = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfStringField);
        }
        
        private void PackValueOfDictionaryField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictionaryField);
        }
        
        private void PackValueOfInt32ArrayField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer1.PackTo(packer, objectTree.Int32ArrayField);
        }
        
        private void PackValueOfStringField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer2.PackTo(packer, objectTree.StringField);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private MsgPack.Serialization.TestValueType CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.TestValueType result = default(MsgPack.Serialization.TestValueType);
            result.DictionaryField = unpackingContext.DictionaryField;
            result.Int32ArrayField = unpackingContext.Int32ArrayField;
            result.StringField = unpackingContext.StringField;
            return result;
        }
        
        private void SetUnpackedValueOfDictionaryField(UnpackingContext unpackingContext, System.Collections.Generic.Dictionary<int, int> unpackedValue) {
            unpackingContext.DictionaryField = unpackedValue;
        }
        
        private void UnpackValueOfDictionaryField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<int, int>), "DictionaryField", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictionaryFieldSetUnpackedValueOfDictionaryFieldDelegate);
        }
        
        private void SetUnpackedValueOfInt32ArrayField(UnpackingContext unpackingContext, int[] unpackedValue) {
            unpackingContext.Int32ArrayField = unpackedValue;
        }
        
        private void UnpackValueOfInt32ArrayField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(int[]), "Int32ArrayField", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfInt32ArrayFieldSetUnpackedValueOfInt32ArrayFieldDelegate);
        }
        
        private void SetUnpackedValueOfStringField(UnpackingContext unpackingContext, string unpackedValue) {
            unpackingContext.StringField = unpackedValue;
        }
        
        private void UnpackValueOfStringField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(string), "StringField", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueUnpackStringValueDelegate, this.this_SetUnpackedValueOfStringFieldSetUnpackedValueOfStringFieldDelegate);
        }
        
        protected internal override MsgPack.Serialization.TestValueType UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Collections.Generic.Dictionary<int, int> ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            int[] ctorArg1 = default(int[]);
            ctorArg1 = default(int[]);
            string ctorArg2 = default(string);
            ctorArg2 = default(string);
            unpackingContext = new UnpackingContext(ctorArg0, ctorArg1, ctorArg2);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextCreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextCreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public System.Collections.Generic.Dictionary<int, int> DictionaryField;
            
            public int[] Int32ArrayField;
            
            public string StringField;
            
            public UnpackingContext(System.Collections.Generic.Dictionary<int, int> DictionaryField, int[] Int32ArrayField, string StringField) {
                this.DictionaryField = DictionaryField;
                this.Int32ArrayField = Int32ArrayField;
                this.StringField = StringField;
            }
        }
    }
}
