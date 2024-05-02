interface ICarnivore
{
    int Value { get; set; } //Also assumed to be public,...
    void EatMeat(); //Assumed to be abstract (traditionally), so it is implied
    //Default access modifier in Interfaces is public b/c (traditionally) private would not make sense. 


}