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
    public class MsgPack_ImageSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Image> {
        
        public MsgPack_ImageSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Image objectTree) {
            objectTree.PackToMessage(packer, null);
        }
        
        protected internal override MsgPack.Image UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Image result = default(MsgPack.Image);
            result = new MsgPack.Image();
            result.UnpackFromMessage(unpacker);
            return result;
        }
    }
}
