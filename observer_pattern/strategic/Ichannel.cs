namespace shavendra{

interface IChannel{
    
    void addObserver(IObserver obj);
    void removeObserver(IObserver obj);
    void updateValue(float temp , float humidity);
}

class Channel:IChannel{

    public float temp { get; set; }
    public float humidity { get; set; }
    public List<IObserver> observers;

public Channel()
    {
        observers = new List<IObserver>();
        this.temp = 0.0f;
        this.humidity = 0.0f;
    }

    public void addObserver(IObserver obj){
        this.observers.Add(obj);
    }

    public void removeObserver(IObserver obj){
        this.observers.Remove(obj);
    }

    

    private void update(){
        foreach (var item in this.observers) // o(n)
        {   
            item.update(this.temp,this.humidity);
        }    
    }

    public void updateValue(float temp , float humidity){
        this.temp = temp;
        this.humidity = humidity;
        this.update();
    }


}


}