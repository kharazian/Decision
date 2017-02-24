﻿using System.Text;
using Decision.Common.SEOToolkit.Twitter.Enums;
using Decision.Common.SEOToolkit.Twitter.Structs;
using NTierMvcFramework.Common.Extensions;

namespace Decision.Common.SEOToolkit.Twitter.Cards
{
    /// <summary>
    ///     The Summary Card can be used for many kinds of web content, from blog posts and news articles, to
    ///     products and restaurants. It is designed to give the reader a preview of the content before clicking
    ///     through to your website. See https://dev.twitter.com/cards/types/summary.
    /// </summary>
    public class SummaryTwitterCard : TwitterCard
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SummaryTwitterCard" /> class.
        /// </summary>
        /// <param name="username">The Twitter username associated with the page e.g. @RehanSaeedUK. This is a required property.</param>
        /// <exception cref="System.ArgumentNullException">username is <c>null</c>.</exception>
        public SummaryTwitterCard(string username)
            : base(username)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Appends a HTML-encoded string representing this instance to the <paramref name="stringBuilder" /> containing the
        ///     Twitter card meta tags.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        public override void ToString(StringBuilder stringBuilder)
        {
            base.ToString(stringBuilder);

            stringBuilder.AppendMetaNameContentIfNotNull("twitter:title", Title);
            stringBuilder.AppendMetaNameContentIfNotNull("twitter:description", Description);
            if (Image != null)
            {
                stringBuilder.AppendMetaNameContent("twitter:image", Image.ImageUrl);
                stringBuilder.AppendMetaNameContentIfNotNull("twitter:image:height", Image.Height);
                stringBuilder.AppendMetaNameContentIfNotNull("twitter:image:width", Image.Width);
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the description that concisely summarizes the content of the page, as appropriate for
        ///     presentation within a Tweet. Do not re-use the title text as the description, or use this field
        ///     to describe the general services provided by the website. Description text will be truncated at
        ///     the word to 200 characters. If you are using Facebook's Open Graph og:description, do not use this
        ///     unless you want a different description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the URL to a unique image representing the content of the page. Do not use a generic
        ///     image such as your website logo, author photo, or other image that spans multiple pages. The
        ///     image must be a minimum size of 120px by 120px and must be less than 1MB in file size. For an
        ///     expanded tweet and its detail page, the image will be cropped to a 4:3 aspect ratio and resized
        ///     to be displayed at 120px by 90px. The image will also be cropped and resized to 120px by 120px
        ///     for use in embedded tweets. If you are using Facebook's Open Graph og:image, you do not have to use
        ///     this unless you want a different image but it is recommended to get supply a smaller image that fits
        ///     Twitters needs.
        /// </summary>
        public TwitterImage Image { get; set; }

        /// <summary>
        ///     Gets or sets the title of the summary. Title should be concise and will be truncated at 70 characters.
        ///     If you are using Facebook's Open Graph og:title, do not use this unless you want a different title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     Gets the type of the Twitter card.
        /// </summary>
        public override TwitterCardType Type => TwitterCardType.Summary;

        #endregion
    }
}