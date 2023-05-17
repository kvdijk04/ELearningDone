﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLearning.Domain.Entites
{
    public class HistoryAddSlot
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public Guid CodeId { get; set; }

        public Guid OldCodeId { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string TypedSubmit { get; set; }

        public string Status { get; set; }

        public Room Room { get; set; }


    }
}
