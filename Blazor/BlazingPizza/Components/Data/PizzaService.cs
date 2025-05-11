using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Components.Data
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
        // Call your data access technology here
        // For this example, we're returning a hardcoded list of pizzas
            var pizzas = new Pizza[]
            {
                new Pizza
                {
                    PizzaId = 1,
                    Name = "페퍼로니 클래식",
                    Description = "전통적인 페퍼로니 피자",
                    Price = 15.99m,
                    Vegetarian = false,
                    Vegan = false
                },
                new Pizza
                {
                    PizzaId = 2,
                    Name = "마르게리타",
                    Description = "신선한 모짜렐라, 바질, 토마토 소스로 만든 피자",
                    Price = 12.99m,
                    Vegetarian = true,
                    Vegan = false
                },
                new Pizza
                {
                    PizzaId = 3,
                    Name = "비건 디럭스",
                    Description = "다양한 야채와 비건 치즈를 올린 피자",
                    Price = 18.50m,
                    Vegetarian = true,
                    Vegan = true
                },
                new Pizza
                {
                    PizzaId = 4,
                    Name = "하와이안",
                    Description = "햄과 파인애플이 어우러진 달콤짭짤한 피자",
                    Price = 16.75m,
                    Vegetarian = false,
                    Vegan = false
                }
            };
            return Task.FromResult(pizzas);
        }
    }
}