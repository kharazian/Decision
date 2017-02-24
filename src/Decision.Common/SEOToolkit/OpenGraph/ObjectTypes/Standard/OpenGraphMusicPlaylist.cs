﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decision.Common.SEOToolkit.OpenGraph.Enums;
using Decision.Common.SEOToolkit.OpenGraph.Media;
using NTierMvcFramework.Common.Extensions;

namespace Decision.Common.SEOToolkit.OpenGraph.ObjectTypes.Standard
{
    /// <summary>
    ///     This object represents a music playlist, an ordered collection of songs from a collection of artists. This object
    ///     type is part of the Open
    ///     Graph standard.
    ///     See http://ogp.me/
    ///     See https://developers.facebook.com/docs/reference/opengraph/object-type/music.playlist/
    /// </summary>
    public class OpenGraphMusicPlaylist : OpenGraphMetadata
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenGraphMusicPlaylist" /> class.
        /// </summary>
        /// <param name="title">The title of the object as it should appear in the graph.</param>
        /// <param name="image">The default image.</param>
        /// <param name="songUrls">
        ///     The URL's to the pages about the songs on this playlist. This URL must contain profile meta tags
        ///     <see cref="OpenGraphMusicSong" />.
        /// </param>
        /// <param name="url">The canonical URL of the object, used as its ID in the graph.</param>
        public OpenGraphMusicPlaylist(string title, OpenGraphImage image, IEnumerable<string> songUrls,
            string url = null)
            : base(title, image, url)
        {
            if (songUrls == null)
            {
                throw new ArgumentNullException(nameof(songUrls));
            }

            SongUrls = songUrls;
            SongDisc = 1;
            SongTrack = 1;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Appends a HTML-encoded string representing this instance to the <paramref name="stringBuilder" /> containing the
        ///     Open Graph meta tags.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        public override void ToString(StringBuilder stringBuilder)
        {
            base.ToString(stringBuilder);

            stringBuilder.AppendMetaPropertyContentIfNotNull("music:song", SongUrls);

            // The number of songs on the playlist. This is a Facebook specific property.
            stringBuilder.AppendMetaPropertyContentIfNotNull("music:song_count", SongUrls.Count());

            stringBuilder.AppendMetaPropertyContent("music:song:disc", SongDisc);
            stringBuilder.AppendMetaPropertyContent("music:song:track", SongTrack);
            stringBuilder.AppendMetaPropertyContentIfNotNull("music:creator", CreatorUrl);
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the URL to the page about the creator of the playlist. This URL must contain profile meta tags
        ///     <see cref="OpenGraphProfile" />.
        /// </summary>
        public string CreatorUrl { get; set; }

        /// <summary>
        ///     Gets the namespace of this open graph type.
        /// </summary>
        public override string Namespace => "music: http://ogp.me/ns/music#";

        /// <summary>
        ///     Gets or sets which disc in the album the song is from.
        /// </summary>
        public int SongDisc { get; set; }

        /// <summary>
        ///     Gets or sets which track in the album the song is from.
        /// </summary>
        public int SongTrack { get; set; }

        /// <summary>
        ///     Gets the URL's to the pages about the songs on this playlist. This URL must contain profile meta tags
        ///     <see cref="OpenGraphMusicSong" />.
        /// </summary>
        public IEnumerable<string> SongUrls { get; }

        /// <summary>
        ///     Gets the type of your object. Depending on the type you specify, other properties may also be required.
        /// </summary>
        public override OpenGraphType Type => OpenGraphType.MusicPlaylist;

        #endregion
    }
}