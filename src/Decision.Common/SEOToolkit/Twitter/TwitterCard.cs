﻿using System;
using System.Text;
using System.Web;
using Decision.Common.SEOToolkit.Twitter.Enums;
using NTierMvcFramework.Common.Extensions;

namespace Decision.Common.SEOToolkit.Twitter
{
    /// <summary>
    ///     With Twitter Cards, you can attach rich photos, videos and media experience to Tweets that drive traffic to your
    ///     website.
    ///     Users who Tweet links to your content will have a "Card" added to the Tweet that’s visible to all of their
    ///     followers.
    ///     See https://dev.twitter.com/cards/overview.
    ///     Sign up for Twitter Card analytics to see who is sharing your site pages on Twitter.
    ///     See https://analytics.twitter.com/about
    ///     Validate your Twitter cards.
    ///     See https://twitter.com/login?redirect_after_login=https%3A%2F%2Fcards-dev.twitter.com%2Fvalidator
    /// </summary>
    public abstract class TwitterCard : IHtmlString
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TwitterCard" /> class.
        /// </summary>
        /// <param name="username">The Twitter username associated with the page e.g. @RehanSaeedUK. This is a required property.</param>
        /// <exception cref="System.ArgumentNullException">username is <c>null</c>.</exception>
        protected TwitterCard(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            Username = username;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the type of the Twitter card.
        /// </summary>
        public abstract TwitterCardType Type { get; }

        /// <summary>
        ///     Gets the Twitter username associated with the page e.g. @RehanSaeedUK. This is a required property.
        /// </summary>
        public string Username { get; }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Returns an HTML-encoded string containing the Twitter card meta tags.
        /// </summary>
        /// <returns>An HTML-encoded string containing the Twitter card meta tags.</returns>
        public string ToHtmlString()
        {
            return ToString();
        }

        /// <summary>
        ///     Returns a HTML-encoded <see cref="System.String" /> that represents this instance containing the Twitter card meta
        ///     tags.
        /// </summary>
        /// <returns>
        ///     A HTML-encoded <see cref="System.String" /> that represents this instance containing the Twitter card meta tags.
        /// </returns>
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            ToString(stringBuilder);
            return stringBuilder.ToString();
        }

        /// <summary>
        ///     Appends a HTML-encoded string representing this instance to the <paramref name="stringBuilder" /> containing the
        ///     Twitter card meta tags.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        public virtual void ToString(StringBuilder stringBuilder)
        {
            if (Type != TwitterCardType.Summary)
            {
                stringBuilder.AppendMetaNameContent("twitter:card", Type.ToTwitterString());
            }

            stringBuilder.AppendMetaNameContent("twitter:site", Username);
        }

        #endregion
    }
}