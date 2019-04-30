/*
 * This file is part of PumaFramework.
 *
 * PumaFramework is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * PumaFramework is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with PumaFramework.  If not, see <https://www.gnu.org/licenses/>.
 */

using CitizenFX.Core;

namespace PumaFramework.Client.Event
{
	public class ThisPlayerSpawnedEvent : GameEvent
	{
		public readonly Vector3 Position;
		public readonly float Heading;
		public readonly int Index;
		public readonly PedHash Model;

		public ThisPlayerSpawnedEvent(Vector3 position, float heading, int index, PedHash model)
		{
			Position = position;
			Heading = heading;
			Index = index;
			Model = model;
		}
	}
}