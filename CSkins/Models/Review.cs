using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSkins.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int SkinId { get; set; }
        public virtual Skin Skin { get; set; }

        public Review()
        {
        }

        public Review(int id, int skinId, string content)
        {
            Id = id;
            SkinId = skinId;
            Content = content;
        }
    }
}