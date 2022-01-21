namespace shavendra{




    interface IObserver{
        void register(IChannel obj);
        void unsubscribe();
        void update(float value1 , float value2);    
    }

    interface Display{
        void Display();
    }

    class SimpleObjserver:IObserver,Display{
        private float temp;
        private float humidity;
        private IChannel? subcriber; // value should be nullable 

        public SimpleObjserver()
        {
            this.temp = 0.0f;
            this.humidity = 0.0f;
            this.subcriber = null;
        }

        public void Display()
        {
        Console.WriteLine($"{this.temp} and {this.humidity}");
        }

        public void register(IChannel obj)
        {
            this.subcriber = obj;
            if (this.subcriber != null){
                this.subcriber.addObserver(this);
        }
        }

        public void unsubscribe()
        {
            if(this.subcriber != null){
                this.subcriber.removeObserver(this);
            }
        }

        public void update(float value1, float value2)
        {
            this.temp = value1;
            this.humidity = value2;
            this.Display();
        }
    }




}