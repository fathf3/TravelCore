﻿namespace Traversal.CQRS.Results.DestinationResult
{
    public class GetAllDestinationQueryResult
    {
        public int id { get; set; }
        public string city { get; set; }
        public string dayNight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }

    }
}
