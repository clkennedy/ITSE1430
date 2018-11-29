/*
 * ITSE 1430 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner
{
    /// <summary>Represents a scheduled event.</summary>
    public class ScheduledEventModel
    {
        public ScheduledEventModel( ScheduledEvent item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            StartDate = item.StartDate;
            EndDate = item.EndDate;
            IsPublic = item.IsPublic;
        }

        /// <summary>Gets or sets the unique ID.</summary>
        [Range(0, Int32.MaxValue)]
        public int Id { get; set; }

        /// <summary>Gets or sets the unique name.</summary>
        [Required(AllowEmptyStrings = false)]
        public string Name{get; set;}

        /// <summary>Gets or sets the description.</summary>
        public string Description { get; set; }

        /// <summary>Gets or sets the start date.</summary>
        public DateTime StartDate { get; set; }

        /// <summary>Gets or sets the end date.</summary>
        
        public DateTime EndDate {
            get ;
            set {
                if (EndDate < StartDate)
                    throw new Exception("End date must be greater than or equal to start date.");
                else
                    EndDate = value;

            } }

        /// <summary>Determines if this is private or public event.</summary>
        public bool IsPublic { get; set; }
        
    }
}
