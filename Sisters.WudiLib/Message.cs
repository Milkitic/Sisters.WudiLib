﻿namespace Sisters.WudiLib
{
    /// <summary>
    /// 各种消息类型的基类。
    /// </summary>
    public abstract class Message
    {
        /// <summary>
        /// 返回发送时要序列化的对象。
        /// </summary>
        internal abstract object Serializing { get; }

        public abstract string Raw { get; }
    }
}