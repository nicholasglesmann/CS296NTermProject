﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class MusicTrack
    {
        [Key]
        public int ID { get; set; }

        private List<MoodTag> moods = new List<MoodTag>();

        private List<InstrumentTag> instruments = new List<InstrumentTag>();

        private List<OtherTag> tags = new List<OtherTag>();

        private List<Comment> comments = new List<Comment>();

        private List<Rating> ratings = new List<Rating>();

        public string Name { get; set; }

        public GenreTag Genre { get; set; }

        public string FileName { get; set; }

        public List<MoodTag> Moods { get { return moods; } set { moods = value; } }

        public List<MusicTrackMoodTag> MusicTrackMoodTags { get; set; } = new List<MusicTrackMoodTag>();

        public List<InstrumentTag> Instruments { get { return instruments; } }

        public List<MusicTrackInstrumentTag> MusicTrackInstrumentTags { get; set; } = new List<MusicTrackInstrumentTag>();

        public List<OtherTag> Tags { get { return tags; } }

        public List<MusicTrackOtherTag> MusicTrackOtherTags { get; set; } = new List<MusicTrackOtherTag>();

        public List<Comment> Comments { get { return comments; } set { comments = value; } }

        public List<Rating> Ratings { get { return ratings; } }

        public void AddInstruments(List<InstrumentTag> tags)
        {
            foreach(InstrumentTag tag in tags)
            {
                instruments.Add(tag);
            }
        }

        public void AddTags(List<OtherTag> tags)
        {
            foreach(OtherTag tag in tags)
            {
                this.tags.Add(tag);
            }
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void AddRating(Rating rating)
        {
            ratings.Add(rating);
        }
    }
}
