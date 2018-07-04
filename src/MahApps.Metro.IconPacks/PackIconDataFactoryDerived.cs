using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MahApps.Metro.IconPacks
{
    public class PackIconEntypoDataFactoryDerived : Dictionary<PackIconEntypoKind, string>, IPackIconDataFactory
    {
        public string GetValue(object key)
        {
            try
            {
                PackIconEntypoKind k = (PackIconEntypoKind)key;
                return this[k];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class PackIconFontAwesomeDataFactoryDerived : Dictionary<PackIconFontAwesomeKind, string>, IPackIconDataFactory
    {
        public string GetValue(object key)
        {
            try
            {
                PackIconFontAwesomeKind k = (PackIconFontAwesomeKind)key;
                return this[k];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class PackIconMaterialDataFactoryDerived : Dictionary<PackIconMaterialKind, string>, IPackIconDataFactory
    {
        public string GetValue(object key)
        {
            try
            {
                PackIconMaterialKind k = (PackIconMaterialKind)key;
                return this[k];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class PackIconMaterialLightDataFactoryDerived : Dictionary<PackIconMaterialLightKind, string>, IPackIconDataFactory
    {
        public string GetValue(object key)
        {
            try
            {
                PackIconMaterialLightKind k = (PackIconMaterialLightKind)key;
                return this[k];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class PackIconModernDataFactoryDerived : Dictionary<PackIconModernKind, string>, IPackIconDataFactory
    {
        public string GetValue(object key)
        {
            try
            {
                PackIconModernKind k = (PackIconModernKind)key;
                return this[k];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class PackIconOcticonsDataFactoryDerived : Dictionary<PackIconOcticonsKind, string>, IPackIconDataFactory
    {
        public string GetValue(object key)
        {
            try
            {
                PackIconOcticonsKind k = (PackIconOcticonsKind)key;
                return this[k];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class PackIconSimpleDataFactoryDerived : Dictionary<PackIconSimpleIconsKind, string>, IPackIconDataFactory
    {
        public string GetValue(object key)
        {
            try
            {
                PackIconSimpleIconsKind k = (PackIconSimpleIconsKind)key;
                return this[k];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
