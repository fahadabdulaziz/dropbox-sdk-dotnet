// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.StoneFixtures
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The mixed internal only enum object</para>
    /// </summary>
    public class MixedInternalOnlyEnum
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MixedInternalOnlyEnum> Encoder = new MixedInternalOnlyEnumEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MixedInternalOnlyEnum> Decoder = new MixedInternalOnlyEnumDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MixedInternalOnlyEnum" />
        /// class.</para>
        /// </summary>
        public MixedInternalOnlyEnum()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Public</para>
        /// </summary>
        public bool IsPublic
        {
            get
            {
                return this is Public;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Public, or <c>null</c>.</para>
        /// </summary>
        public Public AsPublic
        {
            get
            {
                return this as Public;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MixedInternalOnlyEnum" />.</para>
        /// </summary>
        private class MixedInternalOnlyEnumEncoder : enc.StructEncoder<MixedInternalOnlyEnum>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MixedInternalOnlyEnum value, enc.IJsonWriter writer)
            {
                if (value is Public)
                {
                    WriteProperty(".tag", "public", writer, enc.StringEncoder.Instance);
                    Public.Encoder.EncodeFields((Public)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MixedInternalOnlyEnum" />.</para>
        /// </summary>
        private class MixedInternalOnlyEnumDecoder : enc.UnionDecoder<MixedInternalOnlyEnum>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MixedInternalOnlyEnum"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MixedInternalOnlyEnum Create()
            {
                return new MixedInternalOnlyEnum();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MixedInternalOnlyEnum Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "public":
                        return Public.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The public object</para>
        /// </summary>
        public sealed class Public : MixedInternalOnlyEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Public> Encoder = new PublicEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Public> Decoder = new PublicDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Public" /> class.</para>
            /// </summary>
            private Public()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Public</para>
            /// </summary>
            public static readonly Public Instance = new Public();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Public" />.</para>
            /// </summary>
            private class PublicEncoder : enc.StructEncoder<Public>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Public value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Public" />.</para>
            /// </summary>
            private class PublicDecoder : enc.StructDecoder<Public>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Public" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Public Create()
                {
                    return Public.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : MixedInternalOnlyEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
