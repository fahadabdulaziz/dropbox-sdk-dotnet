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
    /// <para>Changed enterprise admin role.</para>
    /// </summary>
    public class ChangedEnterpriseAdminRoleDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ChangedEnterpriseAdminRoleDetails> Encoder = new ChangedEnterpriseAdminRoleDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ChangedEnterpriseAdminRoleDetails> Decoder = new ChangedEnterpriseAdminRoleDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ChangedEnterpriseAdminRoleDetails" /> class.</para>
        /// </summary>
        /// <param name="previousValue">The member&#x2019s previous enterprise admin
        /// role.</param>
        /// <param name="newValue">The member&#x2019s new enterprise admin role.</param>
        /// <param name="teamName">The name of the member&#x2019s team.</param>
        public ChangedEnterpriseAdminRoleDetails(FedAdminRole previousValue,
                                                 FedAdminRole newValue,
                                                 string teamName)
        {
            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (teamName == null)
            {
                throw new sys.ArgumentNullException("teamName");
            }

            this.PreviousValue = previousValue;
            this.NewValue = newValue;
            this.TeamName = teamName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ChangedEnterpriseAdminRoleDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ChangedEnterpriseAdminRoleDetails()
        {
        }

        /// <summary>
        /// <para>The member&#x2019s previous enterprise admin role.</para>
        /// </summary>
        public FedAdminRole PreviousValue { get; protected set; }

        /// <summary>
        /// <para>The member&#x2019s new enterprise admin role.</para>
        /// </summary>
        public FedAdminRole NewValue { get; protected set; }

        /// <summary>
        /// <para>The name of the member&#x2019s team.</para>
        /// </summary>
        public string TeamName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ChangedEnterpriseAdminRoleDetails" />.</para>
        /// </summary>
        private class ChangedEnterpriseAdminRoleDetailsEncoder : enc.StructEncoder<ChangedEnterpriseAdminRoleDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ChangedEnterpriseAdminRoleDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.FedAdminRole.Encoder);
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.FedAdminRole.Encoder);
                WriteProperty("team_name", value.TeamName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ChangedEnterpriseAdminRoleDetails" />.</para>
        /// </summary>
        private class ChangedEnterpriseAdminRoleDetailsDecoder : enc.StructDecoder<ChangedEnterpriseAdminRoleDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="ChangedEnterpriseAdminRoleDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ChangedEnterpriseAdminRoleDetails Create()
            {
                return new ChangedEnterpriseAdminRoleDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ChangedEnterpriseAdminRoleDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.FedAdminRole.Decoder.Decode(reader);
                        break;
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.FedAdminRole.Decoder.Decode(reader);
                        break;
                    case "team_name":
                        value.TeamName = enc.StringDecoder.Instance.Decode(reader);
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
