class RadioJavanApiConstants {
  static const String HOST_URI = 'r-j-app-desk.com';
  static const String HOST = 'Host';
  static const String API = '/api';
  static const String API_SUFFIX_V2 = API + API_VERSION_V2;
  static const String API_VERSION_V2 = '2';
  static const String RADIOJAVAN_URL = 'https://r-j-app-desk.com';

  static const String HEADER_ACCEPT_ENCODING = 'gzip, deflate, br';
  static const String HEADER_ACCEPT_LANGUAGE = 'Accept-Language';
  static String ACCEPT_LANGUAGE = 'en-US';
  static const String HEADER_USER_AGENT = 'User-Agent';
  static const String USER_AGENT =
      'Radio Javan/3.7.7 (Windows_NT 10.0.19042) com.RadioJavan.RJ.desktop';

  static const String LOGIN = API_SUFFIX_V2 + '/login';
  static const String FORGOT = API_SUFFIX_V2 + '/forgot';
  static const String REGISTER = API_SUFFIX_V2 + '/signup_mobile';
}
