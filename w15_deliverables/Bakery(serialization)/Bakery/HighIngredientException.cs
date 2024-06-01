using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery;

internal class HighIngredientException(int amount) : Exception($"There are too many ({amount}) ingredients in this sandwich.");