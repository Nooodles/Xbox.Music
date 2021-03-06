﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xbox.Music
{

    /// <summary>
    /// The creator or creators of a musical recording. 
    /// </summary>
    /// <remarks>
    /// Documentation found at http://msdn.microsoft.com/en-us/library/dn546680.aspx
    /// </remarks>
    [DataContract]
    public class Artist : EntryBase
    {

        #region Properties

        /// <summary>
        /// The list of musical genres associated with this artist.
        /// </summary>
        [DataMember]
        public List<string> Genres { get; set; }

        /// <summary>
        /// A list of musical sub-genres associated with the artist.
        /// </summary>
        [DataMember]
        public List<string> Subgenres { get; set; }

        /// <summary>
        /// An optional paginated list of related artists. 
        /// </summary>
        /// <remarks>
        /// This list is null by default unless requested as extra information in a lookup request. Artists in this list contain 
        /// only a few fields, including the ID that should be used in a lookup request in order to have the full artist properties.
        /// </remarks>
        [DataMember]
        public List<Artist> RelatedArtists { get; set; }

        /// <summary>
        /// An optional paginated list of the artist's albums, ordered by decreasing order of release date (latest first).
        /// </summary>
        /// <remarks>
        /// This list is null by default unless requested as extra information in a lookup request. Albums in this list contain only 
        /// a few fields, including the ID that should be used in a lookup request in order to have the full album properties.
        /// </remarks>
        [DataMember]
        public PaginatedList<Album> Albums { get; set; }

        /// <summary>
        /// A paginated list of the artist's top tracks, ordered by decreasing order of popularity. 
        /// </summary>
        /// <remarks>
        /// This list is null by default unless requested as extra information in a lookup request. Tracks in this list contain 
        /// only a few fields, including the ID that should be used in a lookup request in order to have the full track properties.
        /// </remarks>
        [DataMember]
        public PaginatedList<Track> TopTracks { get; set; }

        #endregion

        #region Public Methods


        #endregion


    }
}