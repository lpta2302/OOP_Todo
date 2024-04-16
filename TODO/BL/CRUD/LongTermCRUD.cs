﻿public class LongTermCRUD : TaskCRUD
{
    private static readonly LongTermCRUD instance = new LongTermCRUD();
    private LongTermCRUD() { }
    public static LongTermCRUD Instance { get { return instance; } }
    public override Task? Create(object[] args)
    {
        LongTerm task = new LongTerm(
            (string)args[0],
            (string)args[1],
            (string)args[2],
            (DateTime)args[3],
            (DateTime)args[4],
            (DateTime)args[5],
            (bool)args[6],
            (bool)args[7],
            (bool)args[8],
            new List<Detail>()
        );

        GlobalData.CurrentTasks.Add(task);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return task;
    }
}