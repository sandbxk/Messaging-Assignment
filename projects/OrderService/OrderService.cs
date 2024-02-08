using MessageClient;
using Messages;
using OrderService.Core.Mappers;

namespace OrderService;

public class OrderService
{
  private readonly MessageClient<OrderRequestMessage> _newOrderClient;
  private readonly MessageClient<OrderResponseMessage> _orderCompletionClient;
  private readonly Core.Services.OrderService _orderService;
  private readonly OrderResponseMapper _orderResponseMapper;
  public OrderService(MessageClient<OrderRequestMessage> newOrderClient, MessageClient<OrderResponseMessage> orderCompletionClient, Core.Services.OrderService orderService, OrderResponseMapper orderResponseMapper)
  {
    _newOrderClient = newOrderClient;
    _orderCompletionClient = orderCompletionClient;
    _orderService = orderService;
    _orderResponseMapper = orderResponseMapper;
  }

  public void Start()
  {
    // TODO: Start listening for new orders
    // TODO: Start listening for order completions
  }

  private void HandleNewOrder(OrderRequestMessage order)
  {
    /*
     * TODO: Handle new orders
     * - Check if the order is valid
     * - Create the order in the database (optional)
     * - Send the order to the stock service
     */
  }
  
  private void HandleOrderCompletion(OrderResponseMessage order)
  {
      /*
       * TODO: Handle the order completion, e.g. change the order status
       * - Update the order status in the database
       * - Notify the customer
       */
  }
}