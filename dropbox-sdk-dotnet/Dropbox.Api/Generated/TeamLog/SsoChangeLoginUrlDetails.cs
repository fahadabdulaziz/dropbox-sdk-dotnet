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
    /// <para>Changed sign-in URL for SSO.</para>
    /// </summary>
    public class SsoChangeLoginUrlDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SsoChangeLoginUrlDetails> Encoder = new SsoChangeLoginUrlDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SsoChangeLoginUrlDetails> Decoder = new SsoChangeLoginUrlDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangeLoginUrlDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="previousValue">Previous single sign-on login URL.</param>
        /// <param name="newValue">New single sign-on login URL.</param>
        public SsoChangeLoginUrlDetails(string previousValue,
                                        string newValue)
        {
            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.PreviousValue = previousValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangeLoginUrlDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SsoChangeLoginUrlDetails()
        {
        }

        /// <summary>
        /// <para>Previous single sign-on login URL.</para>
        /// </summary>
        public string PreviousValue { get; protected set; }

        /// <summary>
        /// <para>New single sign-on login URL.</para>
        /// </summary>
        public string NewValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SsoChangeLoginUrlDetails" />.</para>
        /// </summary>
        private class SsoChangeLoginUrlDetailsEncoder : enc.StructEncoder<SsoChangeLoginUrlDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SsoChangeLoginUrlDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("previous_value", value.PreviousValue, writer, enc.StringEncoder.Instance);
                WriteProperty("new_value", value.NewValue, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SsoChangeLoginUrlDetails" />.</para>
        /// </summary>
        private class SsoChangeLoginUrlDetailsDecoder : enc.StructDecoder<SsoChangeLoginUrlDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SsoChangeLoginUrlDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SsoChangeLoginUrlDetails Create()
            {
                return new SsoChangeLoginUrlDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SsoChangeLoginUrlDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_value":
                        value.PreviousValue = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_value":
                        value.NewValue = enc.StringDecoder.Instance.Decode(reader);
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
