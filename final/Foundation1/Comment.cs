using System;
using System.Collections.Generic;
public class Comment
{

            public string _commentAuthor {get;set;}
            public string _commentText {get;set;}


            public Comment ( string name, string comment)
            {

                _commentAuthor = name;
                _commentText = comment;
            }



}