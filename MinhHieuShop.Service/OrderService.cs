using MinhHieuShop.Data.Infrastructure;
using MinhHieuShop.Data.Repositories;
using MinhHieuShop.Model.Models;
using System.Collections.Generic;

namespace MinhHieuShop.Service
{
    public interface IOrderService
    {
        bool Create(Order order,List<OrderDetail> orderDetails);
    }
    public class OrderService : IOrderService
    {
        IOrderRepository _orderRepository;
        IOrderDetailRepository _orderDetailRepository;
        IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository,IUnitOfWork unitOfWork)
        {
            this._orderRepository = orderRepository;
            this._orderDetailRepository = orderDetailRepository;
            this._unitOfWork = unitOfWork;
        }
        public bool Create(Order order,List<OrderDetail> orderDetails)
        {
            try
            {
                _orderRepository.Add(order);
                _unitOfWork.Commit();

                foreach (var orderDetail in orderDetails)
                {
                    orderDetail.OrderID = order.ID;
                    _orderDetailRepository.Add(orderDetail);
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        
    }
}
