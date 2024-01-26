using DZ_22_01;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

static Train[] TestData() => new Train[]
{
    new Train
    {
        Carrier="Train1",
        Milleage=1111,
        TechnicalNumber="ff111111",
        ManagerPhoneNumber="111111111111111",
        RegistrationDate=new DateOnly(2020,10,5)
    },
     new Train
    {
        Carrier="Train2",
        Milleage=2222,
        TechnicalNumber="ff222222",
        ManagerPhoneNumber="222222222222222",
        RegistrationDate=new DateOnly(2021,12,10)
    }
};
async Task EnsurePopulated()
{
    using (var db = new ApplicationContext(GetConnectionOption()))
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        db.Trains.AddRange(TestData());
        await db.SaveChangesAsync();
    }
}

DbContextOptions GetConnectionOption()
{
    throw new NotImplementedException();
}

async Task<Train> GetTrainById(int id)
{
    using (var db = new ApplicationContext(GetConnectionOption()))
    {
      return await db.Trains.FirstOrDefaultAsync(e=>e.Id==id);
    }
}
async Task AddTrain(Train train)
{
    using (var db = new ApplicationContext(GetConnectionOption()))
    {
        db.Trains.Add(train);
        await db.SaveChangesAsync();
    }
}

async Task UpdateTrain(Train train)
{
    using (var db = new ApplicationContext(GetConnectionOption()))
    {
        db.Trains.Update(train);
        await db.SaveChangesAsync();
    }
}
async Task RemoveTrain(Train train)
{
    using (var db = new ApplicationContext(GetConnectionOption()))
    {
        db.Trains.Remove(train);
        await db.SaveChangesAsync();
    }
}