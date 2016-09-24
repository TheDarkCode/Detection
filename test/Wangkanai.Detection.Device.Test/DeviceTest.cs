﻿using System;
using Xunit;

namespace Wangkanai.Detection.Test
{
    public class DeviceTest
    {
        [Fact]
        public void cast_valid_type()
        {
            Device device = null;
            try
            {
                device = new Device("mobile");
            }
            catch (DeviceNotFoundException)
            {
                
            }
            Assert.Equal(DeviceType.Mobile, device.Type);
        }

        [Fact]
        public void cast_something_not_valid()
        {
            Type actual = null;
            Device device = null;
            try
            {
                device = new Device("xxx");
            }
            catch (DeviceNotFoundException e)
            {
                actual = e.GetType();
            }
            Assert.Equal(typeof(DeviceNotFoundException), actual);
        }
    }
}