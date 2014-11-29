﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xilium.CefGlue;

namespace RainbowMage.HtmlRenderer
{
    class Client : CefClient
    {
        private readonly Renderer renderer;
        private readonly RenderHandler renderHandler;
        private readonly LifeSpanHandler lifeSpanHandler;

        public Client(Renderer renderer, int windowWidth, int windowHeight)
        {
            this.renderer = renderer;
            this.renderHandler = new RenderHandler(renderer, windowWidth, windowHeight);
            this.lifeSpanHandler = new LifeSpanHandler(renderer);
        }

        protected override CefRenderHandler GetRenderHandler()
        {
            return renderHandler;
        }

        protected override CefLifeSpanHandler GetLifeSpanHandler()
        {
            return lifeSpanHandler;
        }

        public void ResizeView(int width, int height)
        {
            renderHandler.Width = width;
            renderHandler.Height = height;
        }
    }
}
