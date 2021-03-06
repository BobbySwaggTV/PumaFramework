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
using PumaFramework.Core.Container;
using PumaFramework.Core.Event;

namespace PumaFramework.Server {

[Required(typeof(PlayerLifecycleManager))]
public class PlayerLifecycleComponent : Component
{
	[EventSource]
	public readonly Player Player;

	
	public PlayerLifecycleComponent(Player player)
	{
		Player = player;
	}
}

}