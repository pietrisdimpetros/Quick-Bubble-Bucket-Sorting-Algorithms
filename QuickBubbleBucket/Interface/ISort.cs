using QuickBubbleBucket.Models;
using System.Collections.Generic;

namespace QuickBubbleBucket
{
    public interface ISort
    {
        void SortBySizeASC(List<TShirt> tshirts);
        void SortBySizeDESC(List<TShirt> tshirts);
        void SortByColorASC(List<TShirt> tshirts);
        void SortByColorDESC(List<TShirt> tshirts);
        void SortByFabricASC(List<TShirt> tshirts);
        void SortByFabricDESC(List<TShirt> tshirts);
        void SortBySizeThenColorThenFabricASC(List<TShirt> tshirts);
        void SortBySizeThenColorThenFabricDESC(List<TShirt> tshirts);

    }
}