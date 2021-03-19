namespace MultithreadedGravity
{
    struct Body
    {
        public double x;
        public double y;
        public double velX;
        public double velY;
        public double mass;

        public void Interaction(Body other)
        {
            //TODO
        }

        public void Move()
        {
            x += velX;
            y += velY;
        }
    }
}
