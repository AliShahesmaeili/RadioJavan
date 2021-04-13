import 'package:RadioJavanDartAPI/RadioJavanDartAPI.dart';
import 'package:test/test.dart';

void main() {
  group('A group of tests', () {
    Awesome awesome;

    setUp(() {
      awesome = Awesome();
    });

    test('Should Login', () async {
      var login = await LoginAsync('usernadme', 'password');
      expect(login.Succeeded, isTrue);
      print(login.Info.Message);
      // print(login.Value.Message);
    });
  });
}
