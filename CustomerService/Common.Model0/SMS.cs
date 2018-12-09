using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Model
{
    public class SMS
    {


        [Key]
        public int Id { get; set; }
        [ForeignKey("Line")]
        public int LineId { get; set; }
        public Line Line { get; set; }
        public string DestinaionNumber { get; set; }
        public DateTime Time { get; set; }
        public void EditSMS(SMS sms)
        {
            LineId = sms.LineId;
            Line = sms.Line;
            DestinaionNumber = sms.DestinaionNumber;
            Time = sms.Time;
        }
        public SMS NewSMS(int lineId, Line line, string destinaionNumber, DateTime time)
        {
            return new SMS
            {
                LineId = lineId,
                Line = line,
                DestinaionNumber = destinaionNumber,
                Time = time
            };

        }
    }
}
