using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader {
    public class LikeData {
        public string Title { get; set; }
        public string Link { get; set; }

        public LikeData(string Title,string Url ) {
            this.Title = Title;
            this.Link = Url;
        }

        public override string ToString() {
            return Title;
        }
    }
}
