﻿#region License
/*The MIT License (MIT)

Better Tracking

IVesselItem - Interface for vessel element

Copyright (C) 2018 DMagic
 
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace BetterTracking.Unity.Interface
{
    public interface IVesselItem
    {
        string VesselName { get; }

        string VesselSituation { get; }

        string VesselInfo { get; }

        Sprite VesselIcon { get; }

        GameObject VesselImage { get; }

        ToggleGroup VesselToggleGroup { get; }

        void OnIconUpdate();

        void OnToggle(bool isOn);

        void OnVesselEdit();

        void OnVesselSelect();

        void OnMouseChange(PointerEventData data, bool enter);

        void SetUI(VesselItem vessel);

        void SetSubUI(SubVesselItem vessel);

        void SetFullUI(FullVesselItem vessel);
    }
}
