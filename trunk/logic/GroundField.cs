using System;

namespace Cubes
{
	public class GroundField : Field
	{
		public GroundField(int x, int y) : base(x, y)
		{
		}
		public GroundField(Field field) : base(field.X, field.Y)
		{
		}
	}
}
