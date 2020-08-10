// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The search error object</para>
    /// </summary>
    public class SearchError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SearchError> Encoder = new SearchErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SearchError> Decoder = new SearchErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SearchError" /> class.</para>
        /// </summary>
        public SearchError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Path</para>
        /// </summary>
        public bool IsPath
        {
            get
            {
                return this is Path;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Path, or <c>null</c>.</para>
        /// </summary>
        public Path AsPath
        {
            get
            {
                return this as Path;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidArgument</para>
        /// </summary>
        public bool IsInvalidArgument
        {
            get
            {
                return this is InvalidArgument;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidArgument, or <c>null</c>.</para>
        /// </summary>
        public InvalidArgument AsInvalidArgument
        {
            get
            {
                return this as InvalidArgument;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InternalError</para>
        /// </summary>
        public bool IsInternalError
        {
            get
            {
                return this is InternalError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InternalError, or <c>null</c>.</para>
        /// </summary>
        public InternalError AsInternalError
        {
            get
            {
                return this as InternalError;
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
        /// <para>Encoder for  <see cref="SearchError" />.</para>
        /// </summary>
        private class SearchErrorEncoder : enc.StructEncoder<SearchError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SearchError value, enc.IJsonWriter writer)
            {
                if (value is Path)
                {
                    WriteProperty(".tag", "path", writer, enc.StringEncoder.Instance);
                    Path.Encoder.EncodeFields((Path)value, writer);
                    return;
                }
                if (value is InvalidArgument)
                {
                    WriteProperty(".tag", "invalid_argument", writer, enc.StringEncoder.Instance);
                    InvalidArgument.Encoder.EncodeFields((InvalidArgument)value, writer);
                    return;
                }
                if (value is InternalError)
                {
                    WriteProperty(".tag", "internal_error", writer, enc.StringEncoder.Instance);
                    InternalError.Encoder.EncodeFields((InternalError)value, writer);
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
        /// <para>Decoder for  <see cref="SearchError" />.</para>
        /// </summary>
        private class SearchErrorDecoder : enc.UnionDecoder<SearchError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SearchError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SearchError Create()
            {
                return new SearchError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SearchError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "path":
                        return Path.Decoder.DecodeFields(reader);
                    case "invalid_argument":
                        return InvalidArgument.Decoder.DecodeFields(reader);
                    case "internal_error":
                        return InternalError.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The path object</para>
        /// </summary>
        public sealed class Path : SearchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Path> Encoder = new PathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Path> Decoder = new PathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Path(LookupError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            private Path()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookupError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathEncoder : enc.StructEncoder<Path>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Path value, enc.IJsonWriter writer)
                {
                    WriteProperty("path", value.Value, writer, global::Dropbox.Api.Files.LookupError.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathDecoder : enc.StructDecoder<Path>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Path" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Path Create()
                {
                    return new Path();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Path value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "path":
                            value.Value = global::Dropbox.Api.Files.LookupError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The invalid argument object</para>
        /// </summary>
        public sealed class InvalidArgument : SearchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidArgument> Encoder = new InvalidArgumentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidArgument> Decoder = new InvalidArgumentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidArgument" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public InvalidArgument(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidArgument" />
            /// class.</para>
            /// </summary>
            private InvalidArgument()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidArgument" />.</para>
            /// </summary>
            private class InvalidArgumentEncoder : enc.StructEncoder<InvalidArgument>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidArgument value, enc.IJsonWriter writer)
                {
                    if (value.Value != null)
                    {
                        WriteProperty("invalid_argument", value.Value, writer, enc.StringEncoder.Instance);
                    }
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidArgument" />.</para>
            /// </summary>
            private class InvalidArgumentDecoder : enc.StructDecoder<InvalidArgument>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidArgument" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidArgument Create()
                {
                    return new InvalidArgument();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(InvalidArgument value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "invalid_argument":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Something went wrong, please try again.</para>
        /// </summary>
        public sealed class InternalError : SearchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InternalError> Encoder = new InternalErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InternalError> Decoder = new InternalErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InternalError" />
            /// class.</para>
            /// </summary>
            private InternalError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InternalError</para>
            /// </summary>
            public static readonly InternalError Instance = new InternalError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InternalError" />.</para>
            /// </summary>
            private class InternalErrorEncoder : enc.StructEncoder<InternalError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InternalError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InternalError" />.</para>
            /// </summary>
            private class InternalErrorDecoder : enc.StructDecoder<InternalError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InternalError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InternalError Create()
                {
                    return InternalError.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SearchError
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
