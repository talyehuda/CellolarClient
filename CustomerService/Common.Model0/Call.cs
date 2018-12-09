using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Common.Model
{
    public class Call
    {


        [Key]
        public int Id { get; set; }
        [ForeignKey("Line")]
        public int LineId { get; set; }
        public Line Line { get; set; }
        public double Duration { get; set; }
        public string DestinationNumber { get; set; }
        public DateTime Time { get; set; }
        public Call NewCall(int lineId, Line line, double duration, string destinationNumber, DateTime time)
        {
            return new Call
            {
                LineId = lineId,
                Line = line,
                Duration = duration,
                DestinationNumber = destinationNumber,
                Time = time
            };
        }
        public void EditCall(Call call)
        {
            LineId = call.LineId ;
            Line = call.Line ;
            Duration = call.Duration ;
            DestinationNumber = call.DestinationNumber ;
            Time =call.Time;
        }
    }
}
