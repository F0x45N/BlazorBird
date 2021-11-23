namespace BlazorBird.ClassModels
{
    public class BirdModel
    {
        public int DistanceFromGround { get; set; } = 100;

        public void Fall(int gravity)
        {
            DistanceFromGround -= gravity;
        }

    }
}
