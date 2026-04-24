using Contracts;
using MassTransit;
using MongoDB.Entities;


namespace SearchService;


public class AuctionDeltedConsumer : IConsumer<AuctionDeleted>
{
    public async Task Consume(ConsumeContext<AuctionDeleted> context)
    {
        Console.WriteLine("--> Consuming AuctionDeleted: " + context.Message.Id);

        var result = await DB.DeleteAsync<Item>(context.Message.Id.ToString());

        if (!result.IsAcknowledged)
            throw new MessageException(typeof(AuctionDeleted), "Problem deleting auction");
    }

}
