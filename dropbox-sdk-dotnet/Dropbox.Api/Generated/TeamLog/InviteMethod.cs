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
    /// <para>The invite method object</para>
    /// </summary>
    public class InviteMethod
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<InviteMethod> Encoder = new InviteMethodEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<InviteMethod> Decoder = new InviteMethodDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="InviteMethod" /> class.</para>
        /// </summary>
        public InviteMethod()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InviteLink</para>
        /// </summary>
        public bool IsInviteLink
        {
            get
            {
                return this is InviteLink;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InviteLink, or <c>null</c>.</para>
        /// </summary>
        public InviteLink AsInviteLink
        {
            get
            {
                return this as InviteLink;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AutoApprove</para>
        /// </summary>
        public bool IsAutoApprove
        {
            get
            {
                return this is AutoApprove;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AutoApprove, or <c>null</c>.</para>
        /// </summary>
        public AutoApprove AsAutoApprove
        {
            get
            {
                return this as AutoApprove;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MovedFromAnotherTeam</para>
        /// </summary>
        public bool IsMovedFromAnotherTeam
        {
            get
            {
                return this is MovedFromAnotherTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MovedFromAnotherTeam, or <c>null</c>.</para>
        /// </summary>
        public MovedFromAnotherTeam AsMovedFromAnotherTeam
        {
            get
            {
                return this as MovedFromAnotherTeam;
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
        /// <para>Encoder for  <see cref="InviteMethod" />.</para>
        /// </summary>
        private class InviteMethodEncoder : enc.StructEncoder<InviteMethod>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(InviteMethod value, enc.IJsonWriter writer)
            {
                if (value is InviteLink)
                {
                    WriteProperty(".tag", "invite_link", writer, enc.StringEncoder.Instance);
                    InviteLink.Encoder.EncodeFields((InviteLink)value, writer);
                    return;
                }
                if (value is AutoApprove)
                {
                    WriteProperty(".tag", "auto_approve", writer, enc.StringEncoder.Instance);
                    AutoApprove.Encoder.EncodeFields((AutoApprove)value, writer);
                    return;
                }
                if (value is MovedFromAnotherTeam)
                {
                    WriteProperty(".tag", "moved_from_another_team", writer, enc.StringEncoder.Instance);
                    MovedFromAnotherTeam.Encoder.EncodeFields((MovedFromAnotherTeam)value, writer);
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
        /// <para>Decoder for  <see cref="InviteMethod" />.</para>
        /// </summary>
        private class InviteMethodDecoder : enc.UnionDecoder<InviteMethod>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="InviteMethod" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override InviteMethod Create()
            {
                return new InviteMethod();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override InviteMethod Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invite_link":
                        return InviteLink.Decoder.DecodeFields(reader);
                    case "auto_approve":
                        return AutoApprove.Decoder.DecodeFields(reader);
                    case "moved_from_another_team":
                        return MovedFromAnotherTeam.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The invite link object</para>
        /// </summary>
        public sealed class InviteLink : InviteMethod
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InviteLink> Encoder = new InviteLinkEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InviteLink> Decoder = new InviteLinkDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InviteLink" /> class.</para>
            /// </summary>
            private InviteLink()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InviteLink</para>
            /// </summary>
            public static readonly InviteLink Instance = new InviteLink();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InviteLink" />.</para>
            /// </summary>
            private class InviteLinkEncoder : enc.StructEncoder<InviteLink>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InviteLink value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InviteLink" />.</para>
            /// </summary>
            private class InviteLinkDecoder : enc.StructDecoder<InviteLink>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InviteLink" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InviteLink Create()
                {
                    return InviteLink.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The auto approve object</para>
        /// </summary>
        public sealed class AutoApprove : InviteMethod
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AutoApprove> Encoder = new AutoApproveEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AutoApprove> Decoder = new AutoApproveDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AutoApprove" />
            /// class.</para>
            /// </summary>
            private AutoApprove()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AutoApprove</para>
            /// </summary>
            public static readonly AutoApprove Instance = new AutoApprove();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AutoApprove" />.</para>
            /// </summary>
            private class AutoApproveEncoder : enc.StructEncoder<AutoApprove>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AutoApprove value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AutoApprove" />.</para>
            /// </summary>
            private class AutoApproveDecoder : enc.StructDecoder<AutoApprove>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AutoApprove" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AutoApprove Create()
                {
                    return AutoApprove.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The moved from another team object</para>
        /// </summary>
        public sealed class MovedFromAnotherTeam : InviteMethod
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MovedFromAnotherTeam> Encoder = new MovedFromAnotherTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MovedFromAnotherTeam> Decoder = new MovedFromAnotherTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MovedFromAnotherTeam" />
            /// class.</para>
            /// </summary>
            private MovedFromAnotherTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MovedFromAnotherTeam</para>
            /// </summary>
            public static readonly MovedFromAnotherTeam Instance = new MovedFromAnotherTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MovedFromAnotherTeam" />.</para>
            /// </summary>
            private class MovedFromAnotherTeamEncoder : enc.StructEncoder<MovedFromAnotherTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MovedFromAnotherTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MovedFromAnotherTeam" />.</para>
            /// </summary>
            private class MovedFromAnotherTeamDecoder : enc.StructDecoder<MovedFromAnotherTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MovedFromAnotherTeam"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MovedFromAnotherTeam Create()
                {
                    return MovedFromAnotherTeam.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : InviteMethod
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
