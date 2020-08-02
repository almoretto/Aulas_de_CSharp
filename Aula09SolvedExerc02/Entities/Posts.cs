using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09SolvedExerc02
{
    class Posts
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Coment> Coments { get; set; } = new List<Coment>();

        public Posts() { } //default constructor
        public Posts(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        //Methods
        public void AddComent(Coment coment)
        {
            Coments.Add(coment);
        }
        public void RemoveComent(Coment coment)
        {
            Coments.Add(coment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Coment c in Coments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();

        }

    }
}
