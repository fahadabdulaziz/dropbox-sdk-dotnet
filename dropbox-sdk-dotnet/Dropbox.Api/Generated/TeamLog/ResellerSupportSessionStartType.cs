// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The reseller support session start type object</para>
    /// </summary>
    public class ResellerSupportSessionStartType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ResellerSupportSessionStartType> Encoder = new ResellerSupportSessionStartTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ResellerSupportSessionStartType> Decoder = new ResellerSupportSessionStartTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ResellerSupportSessionStartType"
        /// /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public ResellerSupportSessionStartType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ResellerSupportSessionStartType"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ResellerSupportSessionStartType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the reseller support session start type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ResellerSupportSessionStartType" />.</para>
        /// </summary>
        private class ResellerSupportSessionStartTypeEncoder : enc.StructEncoder<ResellerSupportSessionStartType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ResellerSupportSessionStartType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ResellerSupportSessionStartType" />.</para>
        /// </summary>
        private class ResellerSupportSessionStartTypeDecoder : enc.StructDecoder<ResellerSupportSessionStartType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ResellerSupportSessionStartType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ResellerSupportSessionStartType Create()
            {
                return new ResellerSupportSessionStartType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ResellerSupportSessionStartType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}