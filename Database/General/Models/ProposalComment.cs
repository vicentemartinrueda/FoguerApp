﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.General.Models
{
    public partial class ProposalComment
    {
        public ProposalComment()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public int CreatorId { get; set; }

        public User Creator { get; set; }

        public int? ProposalId { get; set; }

        public Proposal Proposal { get; set; }

        #endregion
    }
}
