﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.SendMessageDto
{
    public class CreateSendMessageDto
    {
 
        public string RecevierName { get; set; }
        public string RecevierMail { get; set; }

        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }
    }
}
