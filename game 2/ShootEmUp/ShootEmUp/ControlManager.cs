﻿using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootEmUp
{
    class ControlManager
    {

        List<ControlComponent> _controlComponents = new List<ControlComponent>();
        List<JoystickComponent> _joystickComponents = new List<JoystickComponent>();

        internal Component CreateComponent()
        {
            ControlComponent cc = new ControlComponent(this);
            _controlComponents.Add(cc);
            return cc;
        }

        internal Component CreateJoystickComponent()
        {
            JoystickComponent jc = new JoystickComponent(this);
            jc.setup();
            _joystickComponents.Add(jc);
            return jc;
        }

        public void Control()
        {
            SDL.SDL_Event e;
            // Handle events on queue
            while (SDL.SDL_PollEvent(out e) != 0)
            {
                if (e.type == SDL.SDL_EventType.SDL_QUIT)
                {
                    Game.Quit = true;
                    
                }
                foreach (var component in _controlComponents)
                {
                    component.HandleEvent(e);
                }
            }
        }

        public void JoystickControl()
        {
            SDL.SDL_Event e;
            // Handle events on queue
            while (SDL.SDL_PollEvent(out e) != 0)
            {
                if (e.type == SDL.SDL_EventType.SDL_QUIT)
                {
                    Game.Quit = true;

                }
                foreach (var component in _joystickComponents)
                {
                    component.HandleEvent(e);
                }
            }
        }

    }
}
