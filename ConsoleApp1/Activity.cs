namespace ConsoleApp1
{
    //参加活动，订阅活动任务
    //执行任务，返回任务结果
    //查询结果
    
    
    //记录任务，判断任务是否得奖
    //做了多少
    //奖励
    public class Activity
    {
        public void FinishDo()
        {
            var wt=  new WatchVideoTask();
            var how=new RedPack();
            wt.Do(how);
        }
    }

    //奖品
    public class Prize
    {
        
    }
    
    
    
   public class RedPack:IHowDo
    {
        public Prize Do(WatchVideoTask task)
        {
            return  new Prize();
        }
        public Prize Do(CollectionPick task)
        {
            return  new Prize();
        }
    }
   
    //规则
    public interface IHowDo
    {
        Prize Do(WatchVideoTask task);
        Prize Do(CollectionPick task);
    }

   //任务
    public abstract class Task
    {
        public abstract void Do(IHowDo ds);
    }
    
    //看视频
    public class WatchVideoTask : Task
    {
        public override void Do(IHowDo ds)
        {
            ds.Do(this);
        }
    }
    
    //收集碎片
    public class CollectionPick : Task
    {
        public override void Do(IHowDo ds)
        {
            ds.Do(this);
        }
    }
    
    //答题
    
}