﻿using ApplicationCore.Interfaces.Repository;

namespace BackendLab01;

public class Quizz: IIdentity<int>
{
    public int Id { get; set; }
    
    public string Title { get; }
    
    public List<QuizItem> Items { get; }

    public Quizz(int id, List<QuizItem> items, string title)
    {
        Id = id;
        Items = items;
        Title = title;
    }
    
}