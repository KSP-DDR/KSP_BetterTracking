﻿#region License
/*The MIT License (MIT)

Better Tracking

Tracking_WidgetListener - Listener script attached to tracking station vessel widget prefab

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

using KSP.UI.Screens;
using UnityEngine;

namespace BetterTracking
{
    public class Tracking_WidgetListener : MonoBehaviour
    {
        private TrackingStationWidget _widget;

        private void Awake()
        {
            _widget = GetComponent<TrackingStationWidget>();

            if (_widget == null)
                return;

            _widget.toggle.onValueChanged.AddListener(new UnityEngine.Events.UnityAction<bool>(OnToggle));

            Tracking_Controller.OnWidgetAwake.Invoke(_widget);
        }

        private void OnDestroy()
        {
            if (_widget == null)
                return;

            _widget.toggle.onValueChanged.RemoveListener(new UnityEngine.Events.UnityAction<bool>(OnToggle));
        }

        private void OnToggle(bool isOn)
        {
            if (_widget == null)
                return;
            
            if (isOn)
                Tracking_Controller.OnWidgetSelect.Invoke(_widget);
        }
    }
}
