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
    public class MsgPack_Serialization_StringKeyedCollection_1_System_ObjectArray_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<MsgPack.Serialization.StringKeyedCollection<object[]>, object[]> {
        
        public MsgPack_Serialization_StringKeyedCollection_1_System_ObjectArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_StringKeyedCollection_1_System_ObjectArray_Serializer.RestoreSchema()) {
        }
        
        protected override MsgPack.Serialization.StringKeyedCollection<object[]> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.StringKeyedCollection<object[]> collection = default(MsgPack.Serialization.StringKeyedCollection<object[]>);
            collection = new MsgPack.Serialization.StringKeyedCollection<object[]>();
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
