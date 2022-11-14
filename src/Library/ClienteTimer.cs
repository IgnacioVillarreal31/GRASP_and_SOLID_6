namespace Full_GRASP_And_SOLID
{
    public class ClienteTimer : TimerClient
    {
        public Recipe Recipe{get;set;}
        public ClienteTimer (Recipe recipe)
        {
            this.Recipe = recipe;
        }
        public void TimeOut()
        {
            this.Recipe.Cooked = true;
        }
    }
}