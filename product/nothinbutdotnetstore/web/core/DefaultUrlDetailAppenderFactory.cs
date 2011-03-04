using System;
using nothinbutdotnetstore.utility;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultUrlDetailAppenderFactory:UrlDetailAppenderFactory
    {
        private readonly PropertyNameExpressionMapper _property_name_expression_mapper;

        public DefaultUrlDetailAppenderFactory(PropertyNameExpressionMapper property_name_expression_mapper)
        {
            _property_name_expression_mapper = property_name_expression_mapper;
        }

        public UrlDetailAppender<Item> create_detail_appender_for<Item>(Item item, TokenStore tokens)
        {
            return new DefaultUrlDetailAppender<Item>(_property_name_expression_mapper,tokens,item);
        }
    }
}